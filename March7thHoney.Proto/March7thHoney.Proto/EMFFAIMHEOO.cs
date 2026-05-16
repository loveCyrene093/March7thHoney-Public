using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EMFFAIMHEOO : IMessage<EMFFAIMHEOO>, IMessage, IEquatable<EMFFAIMHEOO>, IDeepCloneable<EMFFAIMHEOO>, IBufferMessage
{
	private static readonly MessageParser<EMFFAIMHEOO> _parser = new MessageParser<EMFFAIMHEOO>(() => new EMFFAIMHEOO());

	private UnknownFieldSet _unknownFields;

	public const int EICEBJPMHMCFieldNumber = 7;

	private uint eICEBJPMHMC_;

	public const int INODHFFOEHNFieldNumber = 8;

	private uint iNODHFFOEHN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EMFFAIMHEOO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EMFFAIMHEOOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EICEBJPMHMC
	{
		get
		{
			return eICEBJPMHMC_;
		}
		set
		{
			eICEBJPMHMC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint INODHFFOEHN
	{
		get
		{
			return iNODHFFOEHN_;
		}
		set
		{
			iNODHFFOEHN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMFFAIMHEOO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMFFAIMHEOO(EMFFAIMHEOO other)
		: this()
	{
		eICEBJPMHMC_ = other.eICEBJPMHMC_;
		iNODHFFOEHN_ = other.iNODHFFOEHN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMFFAIMHEOO Clone()
	{
		return new EMFFAIMHEOO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EMFFAIMHEOO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EMFFAIMHEOO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EICEBJPMHMC != other.EICEBJPMHMC)
		{
			return false;
		}
		if (INODHFFOEHN != other.INODHFFOEHN)
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
		if (EICEBJPMHMC != 0)
		{
			num ^= EICEBJPMHMC.GetHashCode();
		}
		if (INODHFFOEHN != 0)
		{
			num ^= INODHFFOEHN.GetHashCode();
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
		if (EICEBJPMHMC != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(EICEBJPMHMC);
		}
		if (INODHFFOEHN != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(INODHFFOEHN);
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
		if (EICEBJPMHMC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EICEBJPMHMC);
		}
		if (INODHFFOEHN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(INODHFFOEHN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EMFFAIMHEOO other)
	{
		if (other != null)
		{
			if (other.EICEBJPMHMC != 0)
			{
				EICEBJPMHMC = other.EICEBJPMHMC;
			}
			if (other.INODHFFOEHN != 0)
			{
				INODHFFOEHN = other.INODHFFOEHN;
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
			case 56u:
				EICEBJPMHMC = input.ReadUInt32();
				break;
			case 64u:
				INODHFFOEHN = input.ReadUInt32();
				break;
			}
		}
	}
}
