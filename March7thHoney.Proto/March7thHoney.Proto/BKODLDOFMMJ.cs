using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BKODLDOFMMJ : IMessage<BKODLDOFMMJ>, IMessage, IEquatable<BKODLDOFMMJ>, IDeepCloneable<BKODLDOFMMJ>, IBufferMessage
{
	private static readonly MessageParser<BKODLDOFMMJ> _parser = new MessageParser<BKODLDOFMMJ>(() => new BKODLDOFMMJ());

	private UnknownFieldSet _unknownFields;

	public const int EICEBJPMHMCFieldNumber = 1;

	private uint eICEBJPMHMC_;

	public const int DHHGLGJBDMJFieldNumber = 15;

	private uint dHHGLGJBDMJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BKODLDOFMMJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BKODLDOFMMJReflection.Descriptor.MessageTypes[0];

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
	public uint DHHGLGJBDMJ
	{
		get
		{
			return dHHGLGJBDMJ_;
		}
		set
		{
			dHHGLGJBDMJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BKODLDOFMMJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BKODLDOFMMJ(BKODLDOFMMJ other)
		: this()
	{
		eICEBJPMHMC_ = other.eICEBJPMHMC_;
		dHHGLGJBDMJ_ = other.dHHGLGJBDMJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BKODLDOFMMJ Clone()
	{
		return new BKODLDOFMMJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BKODLDOFMMJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BKODLDOFMMJ other)
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
		if (DHHGLGJBDMJ != other.DHHGLGJBDMJ)
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
		if (DHHGLGJBDMJ != 0)
		{
			num ^= DHHGLGJBDMJ.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(EICEBJPMHMC);
		}
		if (DHHGLGJBDMJ != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(DHHGLGJBDMJ);
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
		if (DHHGLGJBDMJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DHHGLGJBDMJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BKODLDOFMMJ other)
	{
		if (other != null)
		{
			if (other.EICEBJPMHMC != 0)
			{
				EICEBJPMHMC = other.EICEBJPMHMC;
			}
			if (other.DHHGLGJBDMJ != 0)
			{
				DHHGLGJBDMJ = other.DHHGLGJBDMJ;
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
				EICEBJPMHMC = input.ReadUInt32();
				break;
			case 120u:
				DHHGLGJBDMJ = input.ReadUInt32();
				break;
			}
		}
	}
}
