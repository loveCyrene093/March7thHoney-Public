using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NPLALEFPIEE : IMessage<NPLALEFPIEE>, IMessage, IEquatable<NPLALEFPIEE>, IDeepCloneable<NPLALEFPIEE>, IBufferMessage
{
	private static readonly MessageParser<NPLALEFPIEE> _parser = new MessageParser<NPLALEFPIEE>(() => new NPLALEFPIEE());

	private UnknownFieldSet _unknownFields;

	public const int EventIdFieldNumber = 1;

	private uint eventId_;

	public const int AMADFJNHMFFFieldNumber = 14;

	private uint aMADFJNHMFF_;

	public const int FCADJEENGMLFieldNumber = 15;

	private uint fCADJEENGML_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NPLALEFPIEE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NPLALEFPIEEReflection.Descriptor.MessageTypes[0];

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
	public uint AMADFJNHMFF
	{
		get
		{
			return aMADFJNHMFF_;
		}
		set
		{
			aMADFJNHMFF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FCADJEENGML
	{
		get
		{
			return fCADJEENGML_;
		}
		set
		{
			fCADJEENGML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NPLALEFPIEE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NPLALEFPIEE(NPLALEFPIEE other)
		: this()
	{
		eventId_ = other.eventId_;
		aMADFJNHMFF_ = other.aMADFJNHMFF_;
		fCADJEENGML_ = other.fCADJEENGML_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NPLALEFPIEE Clone()
	{
		return new NPLALEFPIEE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NPLALEFPIEE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NPLALEFPIEE other)
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
		if (AMADFJNHMFF != other.AMADFJNHMFF)
		{
			return false;
		}
		if (FCADJEENGML != other.FCADJEENGML)
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
		if (AMADFJNHMFF != 0)
		{
			num ^= AMADFJNHMFF.GetHashCode();
		}
		if (FCADJEENGML != 0)
		{
			num ^= FCADJEENGML.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(EventId);
		}
		if (AMADFJNHMFF != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(AMADFJNHMFF);
		}
		if (FCADJEENGML != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(FCADJEENGML);
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
		if (AMADFJNHMFF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AMADFJNHMFF);
		}
		if (FCADJEENGML != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FCADJEENGML);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NPLALEFPIEE other)
	{
		if (other != null)
		{
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			if (other.AMADFJNHMFF != 0)
			{
				AMADFJNHMFF = other.AMADFJNHMFF;
			}
			if (other.FCADJEENGML != 0)
			{
				FCADJEENGML = other.FCADJEENGML;
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
			case 8u:
				EventId = input.ReadUInt32();
				break;
			case 112u:
				AMADFJNHMFF = input.ReadUInt32();
				break;
			case 120u:
				FCADJEENGML = input.ReadUInt32();
				break;
			}
		}
	}
}
