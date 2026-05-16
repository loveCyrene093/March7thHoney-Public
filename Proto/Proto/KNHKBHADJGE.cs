using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KNHKBHADJGE : IMessage<KNHKBHADJGE>, IMessage, IEquatable<KNHKBHADJGE>, IDeepCloneable<KNHKBHADJGE>, IBufferMessage
{
	private static readonly MessageParser<KNHKBHADJGE> _parser = new MessageParser<KNHKBHADJGE>(() => new KNHKBHADJGE());

	private UnknownFieldSet _unknownFields;

	public const int IMMHJMDHDGCFieldNumber = 1;

	private uint iMMHJMDHDGC_;

	public const int IPEBMMPKJLFFieldNumber = 2;

	private uint iPEBMMPKJLF_;

	public const int SpBarFieldNumber = 5;

	private SpBarInfo spBar_;

	public const int PromotionFieldNumber = 9;

	private uint promotion_;

	public const int ExpFieldNumber = 10;

	private uint exp_;

	public const int OKMFEGDIONGFieldNumber = 14;

	private static readonly FieldCodec<AHPCJPMMEMN> _repeated_oKMFEGDIONG_codec = FieldCodec.ForMessage(114u, AHPCJPMMEMN.Parser);

	private readonly RepeatedField<AHPCJPMMEMN> oKMFEGDIONG_ = new RepeatedField<AHPCJPMMEMN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KNHKBHADJGE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KNHKBHADJGEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IMMHJMDHDGC
	{
		get
		{
			return iMMHJMDHDGC_;
		}
		set
		{
			iMMHJMDHDGC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IPEBMMPKJLF
	{
		get
		{
			return iPEBMMPKJLF_;
		}
		set
		{
			iPEBMMPKJLF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpBarInfo SpBar
	{
		get
		{
			return spBar_;
		}
		set
		{
			spBar_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Promotion
	{
		get
		{
			return promotion_;
		}
		set
		{
			promotion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Exp
	{
		get
		{
			return exp_;
		}
		set
		{
			exp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AHPCJPMMEMN> OKMFEGDIONG => oKMFEGDIONG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNHKBHADJGE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNHKBHADJGE(KNHKBHADJGE other)
		: this()
	{
		iMMHJMDHDGC_ = other.iMMHJMDHDGC_;
		iPEBMMPKJLF_ = other.iPEBMMPKJLF_;
		spBar_ = ((other.spBar_ != null) ? other.spBar_.Clone() : null);
		promotion_ = other.promotion_;
		exp_ = other.exp_;
		oKMFEGDIONG_ = other.oKMFEGDIONG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNHKBHADJGE Clone()
	{
		return new KNHKBHADJGE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KNHKBHADJGE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KNHKBHADJGE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IMMHJMDHDGC != other.IMMHJMDHDGC)
		{
			return false;
		}
		if (IPEBMMPKJLF != other.IPEBMMPKJLF)
		{
			return false;
		}
		if (!object.Equals(SpBar, other.SpBar))
		{
			return false;
		}
		if (Promotion != other.Promotion)
		{
			return false;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (!oKMFEGDIONG_.Equals(other.oKMFEGDIONG_))
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
		if (IMMHJMDHDGC != 0)
		{
			num ^= IMMHJMDHDGC.GetHashCode();
		}
		if (IPEBMMPKJLF != 0)
		{
			num ^= IPEBMMPKJLF.GetHashCode();
		}
		if (spBar_ != null)
		{
			num ^= SpBar.GetHashCode();
		}
		if (Promotion != 0)
		{
			num ^= Promotion.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		num ^= oKMFEGDIONG_.GetHashCode();
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
		if (IMMHJMDHDGC != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(IMMHJMDHDGC);
		}
		if (IPEBMMPKJLF != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(IPEBMMPKJLF);
		}
		if (spBar_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(SpBar);
		}
		if (Promotion != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Promotion);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Exp);
		}
		oKMFEGDIONG_.WriteTo(ref output, _repeated_oKMFEGDIONG_codec);
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
		if (IMMHJMDHDGC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IMMHJMDHDGC);
		}
		if (IPEBMMPKJLF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IPEBMMPKJLF);
		}
		if (spBar_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SpBar);
		}
		if (Promotion != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Promotion);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		num += oKMFEGDIONG_.CalculateSize(_repeated_oKMFEGDIONG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KNHKBHADJGE other)
	{
		if (other == null)
		{
			return;
		}
		if (other.IMMHJMDHDGC != 0)
		{
			IMMHJMDHDGC = other.IMMHJMDHDGC;
		}
		if (other.IPEBMMPKJLF != 0)
		{
			IPEBMMPKJLF = other.IPEBMMPKJLF;
		}
		if (other.spBar_ != null)
		{
			if (spBar_ == null)
			{
				SpBar = new SpBarInfo();
			}
			SpBar.MergeFrom(other.SpBar);
		}
		if (other.Promotion != 0)
		{
			Promotion = other.Promotion;
		}
		if (other.Exp != 0)
		{
			Exp = other.Exp;
		}
		oKMFEGDIONG_.Add(other.oKMFEGDIONG_);
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
			case 8u:
				IMMHJMDHDGC = input.ReadUInt32();
				break;
			case 16u:
				IPEBMMPKJLF = input.ReadUInt32();
				break;
			case 42u:
				if (spBar_ == null)
				{
					SpBar = new SpBarInfo();
				}
				input.ReadMessage(SpBar);
				break;
			case 72u:
				Promotion = input.ReadUInt32();
				break;
			case 80u:
				Exp = input.ReadUInt32();
				break;
			case 114u:
				oKMFEGDIONG_.AddEntriesFrom(ref input, _repeated_oKMFEGDIONG_codec);
				break;
			}
		}
	}
}
