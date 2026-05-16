using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NLIDDKHJJDO : IMessage<NLIDDKHJJDO>, IMessage, IEquatable<NLIDDKHJJDO>, IDeepCloneable<NLIDDKHJJDO>, IBufferMessage
{
	private static readonly MessageParser<NLIDDKHJJDO> _parser = new MessageParser<NLIDDKHJJDO>(() => new NLIDDKHJJDO());

	private UnknownFieldSet _unknownFields;

	public const int IDKLMOMEKLEFieldNumber = 5;

	private DFLMKFIFHKB iDKLMOMEKLE_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NLIDDKHJJDO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NLIDDKHJJDOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFLMKFIFHKB IDKLMOMEKLE
	{
		get
		{
			return iDKLMOMEKLE_;
		}
		set
		{
			iDKLMOMEKLE_ = value;
		}
	}

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
	public NLIDDKHJJDO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLIDDKHJJDO(NLIDDKHJJDO other)
		: this()
	{
		iDKLMOMEKLE_ = ((other.iDKLMOMEKLE_ != null) ? other.iDKLMOMEKLE_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLIDDKHJJDO Clone()
	{
		return new NLIDDKHJJDO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NLIDDKHJJDO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NLIDDKHJJDO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(IDKLMOMEKLE, other.IDKLMOMEKLE))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (iDKLMOMEKLE_ != null)
		{
			num ^= IDKLMOMEKLE.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (iDKLMOMEKLE_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(IDKLMOMEKLE);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
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
		if (iDKLMOMEKLE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IDKLMOMEKLE);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NLIDDKHJJDO other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iDKLMOMEKLE_ != null)
		{
			if (iDKLMOMEKLE_ == null)
			{
				IDKLMOMEKLE = new DFLMKFIFHKB();
			}
			IDKLMOMEKLE.MergeFrom(other.IDKLMOMEKLE);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 42u:
				if (iDKLMOMEKLE_ == null)
				{
					IDKLMOMEKLE = new DFLMKFIFHKB();
				}
				input.ReadMessage(IDKLMOMEKLE);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
