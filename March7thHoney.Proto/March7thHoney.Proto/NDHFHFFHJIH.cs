using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NDHFHFFHJIH : IMessage<NDHFHFFHJIH>, IMessage, IEquatable<NDHFHFFHJIH>, IDeepCloneable<NDHFHFFHJIH>, IBufferMessage
{
	private static readonly MessageParser<NDHFHFFHJIH> _parser = new MessageParser<NDHFHFFHJIH>(() => new NDHFHFFHJIH());

	private UnknownFieldSet _unknownFields;

	public const int FMECAHALPKGFieldNumber = 1;

	private ELLNDNEBHDK fMECAHALPKG_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NDHFHFFHJIH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NDHFHFFHJIHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ELLNDNEBHDK FMECAHALPKG
	{
		get
		{
			return fMECAHALPKG_;
		}
		set
		{
			fMECAHALPKG_ = value;
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
	public NDHFHFFHJIH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NDHFHFFHJIH(NDHFHFFHJIH other)
		: this()
	{
		fMECAHALPKG_ = ((other.fMECAHALPKG_ != null) ? other.fMECAHALPKG_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NDHFHFFHJIH Clone()
	{
		return new NDHFHFFHJIH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NDHFHFFHJIH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NDHFHFFHJIH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FMECAHALPKG, other.FMECAHALPKG))
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
		if (fMECAHALPKG_ != null)
		{
			num ^= FMECAHALPKG.GetHashCode();
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
		if (fMECAHALPKG_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(FMECAHALPKG);
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
		if (fMECAHALPKG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FMECAHALPKG);
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
	public void MergeFrom(NDHFHFFHJIH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.fMECAHALPKG_ != null)
		{
			if (fMECAHALPKG_ == null)
			{
				FMECAHALPKG = new ELLNDNEBHDK();
			}
			FMECAHALPKG.MergeFrom(other.FMECAHALPKG);
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
			case 10u:
				if (fMECAHALPKG_ == null)
				{
					FMECAHALPKG = new ELLNDNEBHDK();
				}
				input.ReadMessage(FMECAHALPKG);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
