using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CALIPIKFDEJ : IMessage<CALIPIKFDEJ>, IMessage, IEquatable<CALIPIKFDEJ>, IDeepCloneable<CALIPIKFDEJ>, IBufferMessage
{
	private static readonly MessageParser<CALIPIKFDEJ> _parser = new MessageParser<CALIPIKFDEJ>(() => new CALIPIKFDEJ());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdFieldNumber = 1;

	private uint avatarId_;

	public const int GFOMBGLNLKIFieldNumber = 9;

	private ODMJACIKEPC gFOMBGLNLKI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CALIPIKFDEJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CALIPIKFDEJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODMJACIKEPC GFOMBGLNLKI
	{
		get
		{
			return gFOMBGLNLKI_;
		}
		set
		{
			gFOMBGLNLKI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CALIPIKFDEJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CALIPIKFDEJ(CALIPIKFDEJ other)
		: this()
	{
		avatarId_ = other.avatarId_;
		gFOMBGLNLKI_ = other.gFOMBGLNLKI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CALIPIKFDEJ Clone()
	{
		return new CALIPIKFDEJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CALIPIKFDEJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CALIPIKFDEJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (GFOMBGLNLKI != other.GFOMBGLNLKI)
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
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (GFOMBGLNLKI != ODMJACIKEPC.Pcpdhelpkem)
		{
			num ^= GFOMBGLNLKI.GetHashCode();
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
		if (AvatarId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AvatarId);
		}
		if (GFOMBGLNLKI != ODMJACIKEPC.Pcpdhelpkem)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)GFOMBGLNLKI);
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
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (GFOMBGLNLKI != ODMJACIKEPC.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GFOMBGLNLKI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CALIPIKFDEJ other)
	{
		if (other != null)
		{
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.GFOMBGLNLKI != ODMJACIKEPC.Pcpdhelpkem)
			{
				GFOMBGLNLKI = other.GFOMBGLNLKI;
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
				AvatarId = input.ReadUInt32();
				break;
			case 72u:
				GFOMBGLNLKI = (ODMJACIKEPC)input.ReadEnum();
				break;
			}
		}
	}
}
