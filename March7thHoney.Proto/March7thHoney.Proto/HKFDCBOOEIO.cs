using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HKFDCBOOEIO : IMessage<HKFDCBOOEIO>, IMessage, IEquatable<HKFDCBOOEIO>, IDeepCloneable<HKFDCBOOEIO>, IBufferMessage
{
	private static readonly MessageParser<HKFDCBOOEIO> _parser = new MessageParser<HKFDCBOOEIO>(() => new HKFDCBOOEIO());

	private UnknownFieldSet _unknownFields;

	public const int TeleportIdFieldNumber = 2;

	private uint teleportId_;

	public const int HGIAGJMHDOBFieldNumber = 3;

	private LobbyInteractType hGIAGJMHDOB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HKFDCBOOEIO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HKFDCBOOEIOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TeleportId
	{
		get
		{
			return teleportId_;
		}
		set
		{
			teleportId_ = value;
		}
	}

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
	public HKFDCBOOEIO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKFDCBOOEIO(HKFDCBOOEIO other)
		: this()
	{
		teleportId_ = other.teleportId_;
		hGIAGJMHDOB_ = other.hGIAGJMHDOB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKFDCBOOEIO Clone()
	{
		return new HKFDCBOOEIO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HKFDCBOOEIO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HKFDCBOOEIO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TeleportId != other.TeleportId)
		{
			return false;
		}
		if (HGIAGJMHDOB != other.HGIAGJMHDOB)
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
		if (TeleportId != 0)
		{
			num ^= TeleportId.GetHashCode();
		}
		if (HGIAGJMHDOB != LobbyInteractType.JbpdgdgaeklPcpdhelpkem)
		{
			num ^= HGIAGJMHDOB.GetHashCode();
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
		if (TeleportId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(TeleportId);
		}
		if (HGIAGJMHDOB != LobbyInteractType.JbpdgdgaeklPcpdhelpkem)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)HGIAGJMHDOB);
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
		if (TeleportId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TeleportId);
		}
		if (HGIAGJMHDOB != LobbyInteractType.JbpdgdgaeklPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HGIAGJMHDOB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HKFDCBOOEIO other)
	{
		if (other != null)
		{
			if (other.TeleportId != 0)
			{
				TeleportId = other.TeleportId;
			}
			if (other.HGIAGJMHDOB != LobbyInteractType.JbpdgdgaeklPcpdhelpkem)
			{
				HGIAGJMHDOB = other.HGIAGJMHDOB;
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
				TeleportId = input.ReadUInt32();
				break;
			case 24u:
				HGIAGJMHDOB = (LobbyInteractType)input.ReadEnum();
				break;
			}
		}
	}
}
