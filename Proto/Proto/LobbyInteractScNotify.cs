using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LobbyInteractScNotify : IMessage<LobbyInteractScNotify>, IMessage, IEquatable<LobbyInteractScNotify>, IDeepCloneable<LobbyInteractScNotify>, IBufferMessage
{
	private static readonly MessageParser<LobbyInteractScNotify> _parser = new MessageParser<LobbyInteractScNotify>(() => new LobbyInteractScNotify());

	private UnknownFieldSet _unknownFields;

	public const int HGIAGJMHDOBFieldNumber = 4;

	private LobbyInteractType hGIAGJMHDOB_;

	public const int AONGOEAFKOCFieldNumber = 5;

	private uint aONGOEAFKOC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LobbyInteractScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LobbyInteractScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyInteractType HGIAGJMHDOB
	{
		get
		{
			return hGIAGJMHDOB_;
		}
		set
		{
			hGIAGJMHDOB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AONGOEAFKOC
	{
		get
		{
			return aONGOEAFKOC_;
		}
		set
		{
			aONGOEAFKOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyInteractScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyInteractScNotify(LobbyInteractScNotify other)
		: this()
	{
		hGIAGJMHDOB_ = other.hGIAGJMHDOB_;
		aONGOEAFKOC_ = other.aONGOEAFKOC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyInteractScNotify Clone()
	{
		return new LobbyInteractScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LobbyInteractScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LobbyInteractScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HGIAGJMHDOB != other.HGIAGJMHDOB)
		{
			return false;
		}
		if (AONGOEAFKOC != other.AONGOEAFKOC)
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
		if (HGIAGJMHDOB != LobbyInteractType.JbpdgdgaeklPcpdhelpkem)
		{
			num ^= HGIAGJMHDOB.GetHashCode();
		}
		if (AONGOEAFKOC != 0)
		{
			num ^= AONGOEAFKOC.GetHashCode();
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
		if (HGIAGJMHDOB != LobbyInteractType.JbpdgdgaeklPcpdhelpkem)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)HGIAGJMHDOB);
		}
		if (AONGOEAFKOC != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(AONGOEAFKOC);
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
		if (HGIAGJMHDOB != LobbyInteractType.JbpdgdgaeklPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HGIAGJMHDOB);
		}
		if (AONGOEAFKOC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AONGOEAFKOC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LobbyInteractScNotify other)
	{
		if (other != null)
		{
			if (other.HGIAGJMHDOB != LobbyInteractType.JbpdgdgaeklPcpdhelpkem)
			{
				HGIAGJMHDOB = other.HGIAGJMHDOB;
			}
			if (other.AONGOEAFKOC != 0)
			{
				AONGOEAFKOC = other.AONGOEAFKOC;
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
				HGIAGJMHDOB = (LobbyInteractType)input.ReadEnum();
				break;
			case 40u:
				AONGOEAFKOC = input.ReadUInt32();
				break;
			}
		}
	}
}
