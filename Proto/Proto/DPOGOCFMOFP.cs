using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DPOGOCFMOFP : IMessage<DPOGOCFMOFP>, IMessage, IEquatable<DPOGOCFMOFP>, IDeepCloneable<DPOGOCFMOFP>, IBufferMessage
{
	private static readonly MessageParser<DPOGOCFMOFP> _parser = new MessageParser<DPOGOCFMOFP>(() => new DPOGOCFMOFP());

	private UnknownFieldSet _unknownFields;

	public const int COFELCKDBJEFieldNumber = 4;

	private uint cOFELCKDBJE_;

	public const int FriendRecommendListFieldNumber = 6;

	private static readonly FieldCodec<CLHDILKAKEP> _repeated_friendRecommendList_codec = FieldCodec.ForMessage(50u, CLHDILKAKEP.Parser);

	private readonly RepeatedField<CLHDILKAKEP> friendRecommendList_ = new RepeatedField<CLHDILKAKEP>();

	public const int EDNIACNOPMNFieldNumber = 7;

	private uint eDNIACNOPMN_;

	public const int ODDFEAEEJJDFieldNumber = 12;

	private uint oDDFEAEEJJD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DPOGOCFMOFP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DPOGOCFMOFPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint COFELCKDBJE
	{
		get
		{
			return cOFELCKDBJE_;
		}
		set
		{
			cOFELCKDBJE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CLHDILKAKEP> FriendRecommendList => friendRecommendList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EDNIACNOPMN
	{
		get
		{
			return eDNIACNOPMN_;
		}
		set
		{
			eDNIACNOPMN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ODDFEAEEJJD
	{
		get
		{
			return oDDFEAEEJJD_;
		}
		set
		{
			oDDFEAEEJJD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPOGOCFMOFP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPOGOCFMOFP(DPOGOCFMOFP other)
		: this()
	{
		cOFELCKDBJE_ = other.cOFELCKDBJE_;
		friendRecommendList_ = other.friendRecommendList_.Clone();
		eDNIACNOPMN_ = other.eDNIACNOPMN_;
		oDDFEAEEJJD_ = other.oDDFEAEEJJD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPOGOCFMOFP Clone()
	{
		return new DPOGOCFMOFP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DPOGOCFMOFP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DPOGOCFMOFP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (COFELCKDBJE != other.COFELCKDBJE)
		{
			return false;
		}
		if (!friendRecommendList_.Equals(other.friendRecommendList_))
		{
			return false;
		}
		if (EDNIACNOPMN != other.EDNIACNOPMN)
		{
			return false;
		}
		if (ODDFEAEEJJD != other.ODDFEAEEJJD)
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
		if (COFELCKDBJE != 0)
		{
			num ^= COFELCKDBJE.GetHashCode();
		}
		num ^= friendRecommendList_.GetHashCode();
		if (EDNIACNOPMN != 0)
		{
			num ^= EDNIACNOPMN.GetHashCode();
		}
		if (ODDFEAEEJJD != 0)
		{
			num ^= ODDFEAEEJJD.GetHashCode();
		}
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
		if (COFELCKDBJE != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(COFELCKDBJE);
		}
		friendRecommendList_.WriteTo(ref output, _repeated_friendRecommendList_codec);
		if (EDNIACNOPMN != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(EDNIACNOPMN);
		}
		if (ODDFEAEEJJD != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ODDFEAEEJJD);
		}
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
		if (COFELCKDBJE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(COFELCKDBJE);
		}
		num += friendRecommendList_.CalculateSize(_repeated_friendRecommendList_codec);
		if (EDNIACNOPMN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EDNIACNOPMN);
		}
		if (ODDFEAEEJJD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ODDFEAEEJJD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DPOGOCFMOFP other)
	{
		if (other != null)
		{
			if (other.COFELCKDBJE != 0)
			{
				COFELCKDBJE = other.COFELCKDBJE;
			}
			friendRecommendList_.Add(other.friendRecommendList_);
			if (other.EDNIACNOPMN != 0)
			{
				EDNIACNOPMN = other.EDNIACNOPMN;
			}
			if (other.ODDFEAEEJJD != 0)
			{
				ODDFEAEEJJD = other.ODDFEAEEJJD;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 32u:
				COFELCKDBJE = input.ReadUInt32();
				break;
			case 50u:
				friendRecommendList_.AddEntriesFrom(ref input, _repeated_friendRecommendList_codec);
				break;
			case 56u:
				EDNIACNOPMN = input.ReadUInt32();
				break;
			case 96u:
				ODDFEAEEJJD = input.ReadUInt32();
				break;
			}
		}
	}
}
