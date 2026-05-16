using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JIBMJCBNDKK : IMessage<JIBMJCBNDKK>, IMessage, IEquatable<JIBMJCBNDKK>, IDeepCloneable<JIBMJCBNDKK>, IBufferMessage
{
	private static readonly MessageParser<JIBMJCBNDKK> _parser = new MessageParser<JIBMJCBNDKK>(() => new JIBMJCBNDKK());

	private UnknownFieldSet _unknownFields;

	public const int MILHMICEEGPFieldNumber = 4;

	private CGOENENKKCG mILHMICEEGP_;

	public const int HOHANPJNANAFieldNumber = 9;

	private uint hOHANPJNANA_;

	public const int GEIJDOBKNADFieldNumber = 11;

	private static readonly FieldCodec<GBHHOMHNLKD> _repeated_gEIJDOBKNAD_codec = FieldCodec.ForMessage(90u, GBHHOMHNLKD.Parser);

	private readonly RepeatedField<GBHHOMHNLKD> gEIJDOBKNAD_ = new RepeatedField<GBHHOMHNLKD>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JIBMJCBNDKK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JIBMJCBNDKKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGOENENKKCG MILHMICEEGP
	{
		get
		{
			return mILHMICEEGP_;
		}
		set
		{
			mILHMICEEGP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HOHANPJNANA
	{
		get
		{
			return hOHANPJNANA_;
		}
		set
		{
			hOHANPJNANA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GBHHOMHNLKD> GEIJDOBKNAD => gEIJDOBKNAD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIBMJCBNDKK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIBMJCBNDKK(JIBMJCBNDKK other)
		: this()
	{
		mILHMICEEGP_ = ((other.mILHMICEEGP_ != null) ? other.mILHMICEEGP_.Clone() : null);
		hOHANPJNANA_ = other.hOHANPJNANA_;
		gEIJDOBKNAD_ = other.gEIJDOBKNAD_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIBMJCBNDKK Clone()
	{
		return new JIBMJCBNDKK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JIBMJCBNDKK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JIBMJCBNDKK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MILHMICEEGP, other.MILHMICEEGP))
		{
			return false;
		}
		if (HOHANPJNANA != other.HOHANPJNANA)
		{
			return false;
		}
		if (!gEIJDOBKNAD_.Equals(other.gEIJDOBKNAD_))
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
		if (mILHMICEEGP_ != null)
		{
			num ^= MILHMICEEGP.GetHashCode();
		}
		if (HOHANPJNANA != 0)
		{
			num ^= HOHANPJNANA.GetHashCode();
		}
		num ^= gEIJDOBKNAD_.GetHashCode();
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
		if (mILHMICEEGP_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(MILHMICEEGP);
		}
		if (HOHANPJNANA != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(HOHANPJNANA);
		}
		gEIJDOBKNAD_.WriteTo(ref output, _repeated_gEIJDOBKNAD_codec);
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
		if (mILHMICEEGP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MILHMICEEGP);
		}
		if (HOHANPJNANA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HOHANPJNANA);
		}
		num += gEIJDOBKNAD_.CalculateSize(_repeated_gEIJDOBKNAD_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JIBMJCBNDKK other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mILHMICEEGP_ != null)
		{
			if (mILHMICEEGP_ == null)
			{
				MILHMICEEGP = new CGOENENKKCG();
			}
			MILHMICEEGP.MergeFrom(other.MILHMICEEGP);
		}
		if (other.HOHANPJNANA != 0)
		{
			HOHANPJNANA = other.HOHANPJNANA;
		}
		gEIJDOBKNAD_.Add(other.gEIJDOBKNAD_);
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
			case 34u:
				if (mILHMICEEGP_ == null)
				{
					MILHMICEEGP = new CGOENENKKCG();
				}
				input.ReadMessage(MILHMICEEGP);
				break;
			case 72u:
				HOHANPJNANA = input.ReadUInt32();
				break;
			case 90u:
				gEIJDOBKNAD_.AddEntriesFrom(ref input, _repeated_gEIJDOBKNAD_codec);
				break;
			}
		}
	}
}
