using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MNBAAGCGICN : IMessage<MNBAAGCGICN>, IMessage, IEquatable<MNBAAGCGICN>, IDeepCloneable<MNBAAGCGICN>, IBufferMessage
{
	private static readonly MessageParser<MNBAAGCGICN> _parser = new MessageParser<MNBAAGCGICN>(() => new MNBAAGCGICN());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	public const int IMNOJIDJBNGFieldNumber = 14;

	private NHDKLMIMLKC iMNOJIDJBNG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MNBAAGCGICN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MNBAAGCGICNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHDKLMIMLKC IMNOJIDJBNG
	{
		get
		{
			return iMNOJIDJBNG_;
		}
		set
		{
			iMNOJIDJBNG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MNBAAGCGICN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MNBAAGCGICN(MNBAAGCGICN other)
		: this()
	{
		retcode_ = other.retcode_;
		iMNOJIDJBNG_ = ((other.iMNOJIDJBNG_ != null) ? other.iMNOJIDJBNG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MNBAAGCGICN Clone()
	{
		return new MNBAAGCGICN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MNBAAGCGICN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MNBAAGCGICN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(IMNOJIDJBNG, other.IMNOJIDJBNG))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (iMNOJIDJBNG_ != null)
		{
			num ^= IMNOJIDJBNG.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Retcode);
		}
		if (iMNOJIDJBNG_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(IMNOJIDJBNG);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (iMNOJIDJBNG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMNOJIDJBNG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MNBAAGCGICN other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.iMNOJIDJBNG_ != null)
		{
			if (iMNOJIDJBNG_ == null)
			{
				IMNOJIDJBNG = new NHDKLMIMLKC();
			}
			IMNOJIDJBNG.MergeFrom(other.IMNOJIDJBNG);
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
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			case 114u:
				if (iMNOJIDJBNG_ == null)
				{
					IMNOJIDJBNG = new NHDKLMIMLKC();
				}
				input.ReadMessage(IMNOJIDJBNG);
				break;
			}
		}
	}
}
