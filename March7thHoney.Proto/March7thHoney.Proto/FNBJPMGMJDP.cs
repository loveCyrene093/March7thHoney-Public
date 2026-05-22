using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FNBJPMGMJDP : IMessage<FNBJPMGMJDP>, IMessage, IEquatable<FNBJPMGMJDP>, IDeepCloneable<FNBJPMGMJDP>, IBufferMessage
{
	private static readonly MessageParser<FNBJPMGMJDP> _parser = new MessageParser<FNBJPMGMJDP>(() => new FNBJPMGMJDP());

	private UnknownFieldSet _unknownFields;

	public const int NONOOKBIBOMFieldNumber = 4;

	private uint nONOOKBIBOM_;

	public const int JOGONJILJDLFieldNumber = 8;

	private uint jOGONJILJDL_;

	public const int DHHGLGJBDMJFieldNumber = 11;

	private uint dHHGLGJBDMJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FNBJPMGMJDP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FNBJPMGMJDPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NONOOKBIBOM
	{
		get
		{
			return nONOOKBIBOM_;
		}
		set
		{
			nONOOKBIBOM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JOGONJILJDL
	{
		get
		{
			return jOGONJILJDL_;
		}
		set
		{
			jOGONJILJDL_ = value;
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
	public FNBJPMGMJDP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNBJPMGMJDP(FNBJPMGMJDP other)
		: this()
	{
		nONOOKBIBOM_ = other.nONOOKBIBOM_;
		jOGONJILJDL_ = other.jOGONJILJDL_;
		dHHGLGJBDMJ_ = other.dHHGLGJBDMJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNBJPMGMJDP Clone()
	{
		return new FNBJPMGMJDP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FNBJPMGMJDP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FNBJPMGMJDP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NONOOKBIBOM != other.NONOOKBIBOM)
		{
			return false;
		}
		if (JOGONJILJDL != other.JOGONJILJDL)
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
		if (NONOOKBIBOM != 0)
		{
			num ^= NONOOKBIBOM.GetHashCode();
		}
		if (JOGONJILJDL != 0)
		{
			num ^= JOGONJILJDL.GetHashCode();
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
		if (NONOOKBIBOM != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(NONOOKBIBOM);
		}
		if (JOGONJILJDL != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(JOGONJILJDL);
		}
		if (DHHGLGJBDMJ != 0)
		{
			output.WriteRawTag(88);
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
		if (NONOOKBIBOM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NONOOKBIBOM);
		}
		if (JOGONJILJDL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JOGONJILJDL);
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
	public void MergeFrom(FNBJPMGMJDP other)
	{
		if (other != null)
		{
			if (other.NONOOKBIBOM != 0)
			{
				NONOOKBIBOM = other.NONOOKBIBOM;
			}
			if (other.JOGONJILJDL != 0)
			{
				JOGONJILJDL = other.JOGONJILJDL;
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
			case 32u:
				NONOOKBIBOM = input.ReadUInt32();
				break;
			case 64u:
				JOGONJILJDL = input.ReadUInt32();
				break;
			case 88u:
				DHHGLGJBDMJ = input.ReadUInt32();
				break;
			}
		}
	}
}
