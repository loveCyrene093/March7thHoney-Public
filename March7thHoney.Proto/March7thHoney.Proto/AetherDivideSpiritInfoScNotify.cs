using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AetherDivideSpiritInfoScNotify : IMessage<AetherDivideSpiritInfoScNotify>, IMessage, IEquatable<AetherDivideSpiritInfoScNotify>, IDeepCloneable<AetherDivideSpiritInfoScNotify>, IBufferMessage
{
	private static readonly MessageParser<AetherDivideSpiritInfoScNotify> _parser = new MessageParser<AetherDivideSpiritInfoScNotify>(() => new AetherDivideSpiritInfoScNotify());

	private UnknownFieldSet _unknownFields;

	public const int HKOHIHCBGAAFieldNumber = 7;

	private KNHKBHADJGE hKOHIHCBGAA_;

	public const int FIKLLOCJBGNFieldNumber = 9;

	private uint fIKLLOCJBGN_;

	public const int PBEEJNPMHOFFieldNumber = 12;

	private static readonly FieldCodec<KNHKBHADJGE> _repeated_pBEEJNPMHOF_codec = FieldCodec.ForMessage(98u, KNHKBHADJGE.Parser);

	private readonly RepeatedField<KNHKBHADJGE> pBEEJNPMHOF_ = new RepeatedField<KNHKBHADJGE>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AetherDivideSpiritInfoScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AetherDivideSpiritInfoScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNHKBHADJGE HKOHIHCBGAA
	{
		get
		{
			return hKOHIHCBGAA_;
		}
		set
		{
			hKOHIHCBGAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FIKLLOCJBGN
	{
		get
		{
			return fIKLLOCJBGN_;
		}
		set
		{
			fIKLLOCJBGN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KNHKBHADJGE> PBEEJNPMHOF => pBEEJNPMHOF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherDivideSpiritInfoScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherDivideSpiritInfoScNotify(AetherDivideSpiritInfoScNotify other)
		: this()
	{
		hKOHIHCBGAA_ = ((other.hKOHIHCBGAA_ != null) ? other.hKOHIHCBGAA_.Clone() : null);
		fIKLLOCJBGN_ = other.fIKLLOCJBGN_;
		pBEEJNPMHOF_ = other.pBEEJNPMHOF_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AetherDivideSpiritInfoScNotify Clone()
	{
		return new AetherDivideSpiritInfoScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AetherDivideSpiritInfoScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AetherDivideSpiritInfoScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(HKOHIHCBGAA, other.HKOHIHCBGAA))
		{
			return false;
		}
		if (FIKLLOCJBGN != other.FIKLLOCJBGN)
		{
			return false;
		}
		if (!pBEEJNPMHOF_.Equals(other.pBEEJNPMHOF_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (hKOHIHCBGAA_ != null)
		{
			num ^= HKOHIHCBGAA.GetHashCode();
		}
		if (FIKLLOCJBGN != 0)
		{
			num ^= FIKLLOCJBGN.GetHashCode();
		}
		num ^= pBEEJNPMHOF_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (hKOHIHCBGAA_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(HKOHIHCBGAA);
		}
		if (FIKLLOCJBGN != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(FIKLLOCJBGN);
		}
		pBEEJNPMHOF_.WriteTo(ref output, _repeated_pBEEJNPMHOF_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (hKOHIHCBGAA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HKOHIHCBGAA);
		}
		if (FIKLLOCJBGN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FIKLLOCJBGN);
		}
		num += pBEEJNPMHOF_.CalculateSize(_repeated_pBEEJNPMHOF_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AetherDivideSpiritInfoScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.hKOHIHCBGAA_ != null)
		{
			if (hKOHIHCBGAA_ == null)
			{
				HKOHIHCBGAA = new KNHKBHADJGE();
			}
			HKOHIHCBGAA.MergeFrom(other.HKOHIHCBGAA);
		}
		if (other.FIKLLOCJBGN != 0)
		{
			FIKLLOCJBGN = other.FIKLLOCJBGN;
		}
		pBEEJNPMHOF_.Add(other.pBEEJNPMHOF_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 58u:
				if (hKOHIHCBGAA_ == null)
				{
					HKOHIHCBGAA = new KNHKBHADJGE();
				}
				input.ReadMessage(HKOHIHCBGAA);
				break;
			case 72u:
				FIKLLOCJBGN = input.ReadUInt32();
				break;
			case 98u:
				pBEEJNPMHOF_.AddEntriesFrom(ref input, _repeated_pBEEJNPMHOF_codec);
				break;
			}
		}
	}
}
