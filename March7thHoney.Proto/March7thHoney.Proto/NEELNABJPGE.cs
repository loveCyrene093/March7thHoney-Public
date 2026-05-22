using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NEELNABJPGE : IMessage<NEELNABJPGE>, IMessage, IEquatable<NEELNABJPGE>, IDeepCloneable<NEELNABJPGE>, IBufferMessage
{
	private static readonly MessageParser<NEELNABJPGE> _parser = new MessageParser<NEELNABJPGE>(() => new NEELNABJPGE());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int FMECAHALPKGFieldNumber = 12;

	private ELLNDNEBHDK fMECAHALPKG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NEELNABJPGE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NEELNABJPGEReflection.Descriptor.MessageTypes[0];

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
	public NEELNABJPGE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEELNABJPGE(NEELNABJPGE other)
		: this()
	{
		retcode_ = other.retcode_;
		fMECAHALPKG_ = ((other.fMECAHALPKG_ != null) ? other.fMECAHALPKG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEELNABJPGE Clone()
	{
		return new NEELNABJPGE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NEELNABJPGE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NEELNABJPGE other)
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
		if (!object.Equals(FMECAHALPKG, other.FMECAHALPKG))
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
		if (fMECAHALPKG_ != null)
		{
			num ^= FMECAHALPKG.GetHashCode();
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
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		if (fMECAHALPKG_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(FMECAHALPKG);
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
		if (fMECAHALPKG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FMECAHALPKG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NEELNABJPGE other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.fMECAHALPKG_ != null)
		{
			if (fMECAHALPKG_ == null)
			{
				FMECAHALPKG = new ELLNDNEBHDK();
			}
			FMECAHALPKG.MergeFrom(other.FMECAHALPKG);
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
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 98u:
				if (fMECAHALPKG_ == null)
				{
					FMECAHALPKG = new ELLNDNEBHDK();
				}
				input.ReadMessage(FMECAHALPKG);
				break;
			}
		}
	}
}
