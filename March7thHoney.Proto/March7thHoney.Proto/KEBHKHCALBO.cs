using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KEBHKHCALBO : IMessage<KEBHKHCALBO>, IMessage, IEquatable<KEBHKHCALBO>, IDeepCloneable<KEBHKHCALBO>, IBufferMessage
{
	private static readonly MessageParser<KEBHKHCALBO> _parser = new MessageParser<KEBHKHCALBO>(() => new KEBHKHCALBO());

	private UnknownFieldSet _unknownFields;

	public const int BlackListFieldNumber = 7;

	private KFKDIEAJPCJ blackList_;

	public const int GNDJPNBECJPFieldNumber = 10;

	private bool gNDJPNBECJP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KEBHKHCALBO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KEBHKHCALBOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFKDIEAJPCJ BlackList
	{
		get
		{
			return blackList_;
		}
		set
		{
			blackList_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GNDJPNBECJP
	{
		get
		{
			return gNDJPNBECJP_;
		}
		set
		{
			gNDJPNBECJP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KEBHKHCALBO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KEBHKHCALBO(KEBHKHCALBO other)
		: this()
	{
		blackList_ = ((other.blackList_ != null) ? other.blackList_.Clone() : null);
		gNDJPNBECJP_ = other.gNDJPNBECJP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KEBHKHCALBO Clone()
	{
		return new KEBHKHCALBO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KEBHKHCALBO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KEBHKHCALBO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BlackList, other.BlackList))
		{
			return false;
		}
		if (GNDJPNBECJP != other.GNDJPNBECJP)
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
		if (blackList_ != null)
		{
			num ^= BlackList.GetHashCode();
		}
		if (GNDJPNBECJP)
		{
			num ^= GNDJPNBECJP.GetHashCode();
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
		if (blackList_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(BlackList);
		}
		if (GNDJPNBECJP)
		{
			output.WriteRawTag(80);
			output.WriteBool(GNDJPNBECJP);
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
		if (blackList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BlackList);
		}
		if (GNDJPNBECJP)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KEBHKHCALBO other)
	{
		if (other == null)
		{
			return;
		}
		if (other.blackList_ != null)
		{
			if (blackList_ == null)
			{
				BlackList = new KFKDIEAJPCJ();
			}
			BlackList.MergeFrom(other.BlackList);
		}
		if (other.GNDJPNBECJP)
		{
			GNDJPNBECJP = other.GNDJPNBECJP;
		}
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
				if (blackList_ == null)
				{
					BlackList = new KFKDIEAJPCJ();
				}
				input.ReadMessage(BlackList);
				break;
			case 80u:
				GNDJPNBECJP = input.ReadBool();
				break;
			}
		}
	}
}
