using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FLIPDLFKMLB : IMessage<FLIPDLFKMLB>, IMessage, IEquatable<FLIPDLFKMLB>, IDeepCloneable<FLIPDLFKMLB>, IBufferMessage
{
	private static readonly MessageParser<FLIPDLFKMLB> _parser = new MessageParser<FLIPDLFKMLB>(() => new FLIPDLFKMLB());

	private UnknownFieldSet _unknownFields;

	public const int EventIdFieldNumber = 3;

	private uint eventId_;

	public const int EMFHLBBOCFKFieldNumber = 5;

	private uint eMFHLBBOCFK_;

	public const int ECMNOFCMIGJFieldNumber = 7;

	private uint eCMNOFCMIGJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FLIPDLFKMLB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FLIPDLFKMLBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EMFHLBBOCFK
	{
		get
		{
			return eMFHLBBOCFK_;
		}
		set
		{
			eMFHLBBOCFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ECMNOFCMIGJ
	{
		get
		{
			return eCMNOFCMIGJ_;
		}
		set
		{
			eCMNOFCMIGJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FLIPDLFKMLB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FLIPDLFKMLB(FLIPDLFKMLB other)
		: this()
	{
		eventId_ = other.eventId_;
		eMFHLBBOCFK_ = other.eMFHLBBOCFK_;
		eCMNOFCMIGJ_ = other.eCMNOFCMIGJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FLIPDLFKMLB Clone()
	{
		return new FLIPDLFKMLB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FLIPDLFKMLB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FLIPDLFKMLB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EventId != other.EventId)
		{
			return false;
		}
		if (EMFHLBBOCFK != other.EMFHLBBOCFK)
		{
			return false;
		}
		if (ECMNOFCMIGJ != other.ECMNOFCMIGJ)
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
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		if (EMFHLBBOCFK != 0)
		{
			num ^= EMFHLBBOCFK.GetHashCode();
		}
		if (ECMNOFCMIGJ != 0)
		{
			num ^= ECMNOFCMIGJ.GetHashCode();
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
		if (EventId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(EventId);
		}
		if (EMFHLBBOCFK != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(EMFHLBBOCFK);
		}
		if (ECMNOFCMIGJ != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ECMNOFCMIGJ);
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
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EventId);
		}
		if (EMFHLBBOCFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EMFHLBBOCFK);
		}
		if (ECMNOFCMIGJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ECMNOFCMIGJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FLIPDLFKMLB other)
	{
		if (other != null)
		{
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			if (other.EMFHLBBOCFK != 0)
			{
				EMFHLBBOCFK = other.EMFHLBBOCFK;
			}
			if (other.ECMNOFCMIGJ != 0)
			{
				ECMNOFCMIGJ = other.ECMNOFCMIGJ;
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
			case 24u:
				EventId = input.ReadUInt32();
				break;
			case 40u:
				EMFHLBBOCFK = input.ReadUInt32();
				break;
			case 56u:
				ECMNOFCMIGJ = input.ReadUInt32();
				break;
			}
		}
	}
}
