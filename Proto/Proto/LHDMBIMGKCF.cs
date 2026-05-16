using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LHDMBIMGKCF : IMessage<LHDMBIMGKCF>, IMessage, IEquatable<LHDMBIMGKCF>, IDeepCloneable<LHDMBIMGKCF>, IBufferMessage
{
	private static readonly MessageParser<LHDMBIMGKCF> _parser = new MessageParser<LHDMBIMGKCF>(() => new LHDMBIMGKCF());

	private UnknownFieldSet _unknownFields;

	public const int FLICPMGFKOKFieldNumber = 8;

	private uint fLICPMGFKOK_;

	public const int RoleIdFieldNumber = 13;

	private uint roleId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LHDMBIMGKCF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LHDMBIMGKCFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FLICPMGFKOK
	{
		get
		{
			return fLICPMGFKOK_;
		}
		set
		{
			fLICPMGFKOK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHDMBIMGKCF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHDMBIMGKCF(LHDMBIMGKCF other)
		: this()
	{
		fLICPMGFKOK_ = other.fLICPMGFKOK_;
		roleId_ = other.roleId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHDMBIMGKCF Clone()
	{
		return new LHDMBIMGKCF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LHDMBIMGKCF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LHDMBIMGKCF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FLICPMGFKOK != other.FLICPMGFKOK)
		{
			return false;
		}
		if (RoleId != other.RoleId)
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
		if (FLICPMGFKOK != 0)
		{
			num ^= FLICPMGFKOK.GetHashCode();
		}
		if (RoleId != 0)
		{
			num ^= RoleId.GetHashCode();
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
		if (FLICPMGFKOK != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(FLICPMGFKOK);
		}
		if (RoleId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(RoleId);
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
		if (FLICPMGFKOK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FLICPMGFKOK);
		}
		if (RoleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoleId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LHDMBIMGKCF other)
	{
		if (other != null)
		{
			if (other.FLICPMGFKOK != 0)
			{
				FLICPMGFKOK = other.FLICPMGFKOK;
			}
			if (other.RoleId != 0)
			{
				RoleId = other.RoleId;
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
			case 64u:
				FLICPMGFKOK = input.ReadUInt32();
				break;
			case 104u:
				RoleId = input.ReadUInt32();
				break;
			}
		}
	}
}
