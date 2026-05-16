using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerReturnInfoQueryCsReq : IMessage<PlayerReturnInfoQueryCsReq>, IMessage, IEquatable<PlayerReturnInfoQueryCsReq>, IDeepCloneable<PlayerReturnInfoQueryCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlayerReturnInfoQueryCsReq> _parser = new MessageParser<PlayerReturnInfoQueryCsReq>(() => new PlayerReturnInfoQueryCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ACBNHJKFFMPFieldNumber = 3;

	private uint aCBNHJKFFMP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerReturnInfoQueryCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerReturnInfoQueryCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ACBNHJKFFMP
	{
		get
		{
			return aCBNHJKFFMP_;
		}
		set
		{
			aCBNHJKFFMP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnInfoQueryCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnInfoQueryCsReq(PlayerReturnInfoQueryCsReq other)
		: this()
	{
		aCBNHJKFFMP_ = other.aCBNHJKFFMP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnInfoQueryCsReq Clone()
	{
		return new PlayerReturnInfoQueryCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerReturnInfoQueryCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerReturnInfoQueryCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ACBNHJKFFMP != other.ACBNHJKFFMP)
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
		if (ACBNHJKFFMP != 0)
		{
			num ^= ACBNHJKFFMP.GetHashCode();
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
		if (ACBNHJKFFMP != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ACBNHJKFFMP);
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
		if (ACBNHJKFFMP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ACBNHJKFFMP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerReturnInfoQueryCsReq other)
	{
		if (other != null)
		{
			if (other.ACBNHJKFFMP != 0)
			{
				ACBNHJKFFMP = other.ACBNHJKFFMP;
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
			if (num != 24)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				ACBNHJKFFMP = input.ReadUInt32();
			}
		}
	}
}
