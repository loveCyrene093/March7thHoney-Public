using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChimeraDuelSellChimeraCsReq : IMessage<ChimeraDuelSellChimeraCsReq>, IMessage, IEquatable<ChimeraDuelSellChimeraCsReq>, IDeepCloneable<ChimeraDuelSellChimeraCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChimeraDuelSellChimeraCsReq> _parser = new MessageParser<ChimeraDuelSellChimeraCsReq>(() => new ChimeraDuelSellChimeraCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DEAKOOEBLJLFieldNumber = 3;

	private uint dEAKOOEBLJL_;

	public const int MEKLIKLGAFIFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_mEKLIKLGAFI_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> mEKLIKLGAFI_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChimeraDuelSellChimeraCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChimeraDuelSellChimeraCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DEAKOOEBLJL
	{
		get
		{
			return dEAKOOEBLJL_;
		}
		set
		{
			dEAKOOEBLJL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MEKLIKLGAFI => mEKLIKLGAFI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelSellChimeraCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelSellChimeraCsReq(ChimeraDuelSellChimeraCsReq other)
		: this()
	{
		dEAKOOEBLJL_ = other.dEAKOOEBLJL_;
		mEKLIKLGAFI_ = other.mEKLIKLGAFI_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelSellChimeraCsReq Clone()
	{
		return new ChimeraDuelSellChimeraCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChimeraDuelSellChimeraCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChimeraDuelSellChimeraCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DEAKOOEBLJL != other.DEAKOOEBLJL)
		{
			return false;
		}
		if (!mEKLIKLGAFI_.Equals(other.mEKLIKLGAFI_))
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
		if (DEAKOOEBLJL != 0)
		{
			num ^= DEAKOOEBLJL.GetHashCode();
		}
		num ^= mEKLIKLGAFI_.GetHashCode();
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
		if (DEAKOOEBLJL != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(DEAKOOEBLJL);
		}
		mEKLIKLGAFI_.WriteTo(ref output, _repeated_mEKLIKLGAFI_codec);
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
		if (DEAKOOEBLJL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DEAKOOEBLJL);
		}
		num += mEKLIKLGAFI_.CalculateSize(_repeated_mEKLIKLGAFI_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChimeraDuelSellChimeraCsReq other)
	{
		if (other != null)
		{
			if (other.DEAKOOEBLJL != 0)
			{
				DEAKOOEBLJL = other.DEAKOOEBLJL;
			}
			mEKLIKLGAFI_.Add(other.mEKLIKLGAFI_);
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
			case 24u:
				DEAKOOEBLJL = input.ReadUInt32();
				break;
			case 80u:
			case 82u:
				mEKLIKLGAFI_.AddEntriesFrom(ref input, _repeated_mEKLIKLGAFI_codec);
				break;
			}
		}
	}
}
