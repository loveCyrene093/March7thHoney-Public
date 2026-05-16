using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MGFEMHKICND : IMessage<MGFEMHKICND>, IMessage, IEquatable<MGFEMHKICND>, IDeepCloneable<MGFEMHKICND>, IBufferMessage
{
	private static readonly MessageParser<MGFEMHKICND> _parser = new MessageParser<MGFEMHKICND>(() => new MGFEMHKICND());

	private UnknownFieldSet _unknownFields;

	public const int LCHDAPELPGOFieldNumber = 2;

	private uint lCHDAPELPGO_;

	public const int JOCDMEHNLADFieldNumber = 4;

	private uint jOCDMEHNLAD_;

	public const int UidFieldNumber = 13;

	private uint uid_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MGFEMHKICND> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MGFEMHKICNDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LCHDAPELPGO
	{
		get
		{
			return lCHDAPELPGO_;
		}
		set
		{
			lCHDAPELPGO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JOCDMEHNLAD
	{
		get
		{
			return jOCDMEHNLAD_;
		}
		set
		{
			jOCDMEHNLAD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MGFEMHKICND()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MGFEMHKICND(MGFEMHKICND other)
		: this()
	{
		lCHDAPELPGO_ = other.lCHDAPELPGO_;
		jOCDMEHNLAD_ = other.jOCDMEHNLAD_;
		uid_ = other.uid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MGFEMHKICND Clone()
	{
		return new MGFEMHKICND(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MGFEMHKICND);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MGFEMHKICND other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LCHDAPELPGO != other.LCHDAPELPGO)
		{
			return false;
		}
		if (JOCDMEHNLAD != other.JOCDMEHNLAD)
		{
			return false;
		}
		if (Uid != other.Uid)
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
		if (LCHDAPELPGO != 0)
		{
			num ^= LCHDAPELPGO.GetHashCode();
		}
		if (JOCDMEHNLAD != 0)
		{
			num ^= JOCDMEHNLAD.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
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
		if (LCHDAPELPGO != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(LCHDAPELPGO);
		}
		if (JOCDMEHNLAD != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(JOCDMEHNLAD);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Uid);
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
		if (LCHDAPELPGO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LCHDAPELPGO);
		}
		if (JOCDMEHNLAD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JOCDMEHNLAD);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MGFEMHKICND other)
	{
		if (other != null)
		{
			if (other.LCHDAPELPGO != 0)
			{
				LCHDAPELPGO = other.LCHDAPELPGO;
			}
			if (other.JOCDMEHNLAD != 0)
			{
				JOCDMEHNLAD = other.JOCDMEHNLAD;
			}
			if (other.Uid != 0)
			{
				Uid = other.Uid;
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
			case 16u:
				LCHDAPELPGO = input.ReadUInt32();
				break;
			case 32u:
				JOCDMEHNLAD = input.ReadUInt32();
				break;
			case 104u:
				Uid = input.ReadUInt32();
				break;
			}
		}
	}
}
