using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GBPEEKKNCOK : IMessage<GBPEEKKNCOK>, IMessage, IEquatable<GBPEEKKNCOK>, IDeepCloneable<GBPEEKKNCOK>, IBufferMessage
{
	private static readonly MessageParser<GBPEEKKNCOK> _parser = new MessageParser<GBPEEKKNCOK>(() => new GBPEEKKNCOK());

	private UnknownFieldSet _unknownFields;

	public const int CACHGIFMPMOFieldNumber = 5;

	private uint cACHGIFMPMO_;

	public const int CGDOBAOAHMBFieldNumber = 12;

	private string cGDOBAOAHMB_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GBPEEKKNCOK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GBPEEKKNCOKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CACHGIFMPMO
	{
		get
		{
			return cACHGIFMPMO_;
		}
		set
		{
			cACHGIFMPMO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CGDOBAOAHMB
	{
		get
		{
			return cGDOBAOAHMB_;
		}
		set
		{
			cGDOBAOAHMB_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GBPEEKKNCOK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GBPEEKKNCOK(GBPEEKKNCOK other)
		: this()
	{
		cACHGIFMPMO_ = other.cACHGIFMPMO_;
		cGDOBAOAHMB_ = other.cGDOBAOAHMB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GBPEEKKNCOK Clone()
	{
		return new GBPEEKKNCOK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GBPEEKKNCOK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GBPEEKKNCOK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CACHGIFMPMO != other.CACHGIFMPMO)
		{
			return false;
		}
		if (CGDOBAOAHMB != other.CGDOBAOAHMB)
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
		if (CACHGIFMPMO != 0)
		{
			num ^= CACHGIFMPMO.GetHashCode();
		}
		if (CGDOBAOAHMB.Length != 0)
		{
			num ^= CGDOBAOAHMB.GetHashCode();
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
		if (CACHGIFMPMO != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(CACHGIFMPMO);
		}
		if (CGDOBAOAHMB.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(CGDOBAOAHMB);
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
		if (CACHGIFMPMO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CACHGIFMPMO);
		}
		if (CGDOBAOAHMB.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CGDOBAOAHMB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GBPEEKKNCOK other)
	{
		if (other != null)
		{
			if (other.CACHGIFMPMO != 0)
			{
				CACHGIFMPMO = other.CACHGIFMPMO;
			}
			if (other.CGDOBAOAHMB.Length != 0)
			{
				CGDOBAOAHMB = other.CGDOBAOAHMB;
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
			case 40u:
				CACHGIFMPMO = input.ReadUInt32();
				break;
			case 98u:
				CGDOBAOAHMB = input.ReadString();
				break;
			}
		}
	}
}
