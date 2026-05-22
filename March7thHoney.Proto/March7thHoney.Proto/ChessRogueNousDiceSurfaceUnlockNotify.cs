using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueNousDiceSurfaceUnlockNotify : IMessage<ChessRogueNousDiceSurfaceUnlockNotify>, IMessage, IEquatable<ChessRogueNousDiceSurfaceUnlockNotify>, IDeepCloneable<ChessRogueNousDiceSurfaceUnlockNotify>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueNousDiceSurfaceUnlockNotify> _parser = new MessageParser<ChessRogueNousDiceSurfaceUnlockNotify>(() => new ChessRogueNousDiceSurfaceUnlockNotify());

	private UnknownFieldSet _unknownFields;

	public const int DIAAMODKAMOFieldNumber = 15;

	private uint dIAAMODKAMO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueNousDiceSurfaceUnlockNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueNousDiceSurfaceUnlockNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DIAAMODKAMO
	{
		get
		{
			return dIAAMODKAMO_;
		}
		set
		{
			dIAAMODKAMO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueNousDiceSurfaceUnlockNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueNousDiceSurfaceUnlockNotify(ChessRogueNousDiceSurfaceUnlockNotify other)
		: this()
	{
		dIAAMODKAMO_ = other.dIAAMODKAMO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueNousDiceSurfaceUnlockNotify Clone()
	{
		return new ChessRogueNousDiceSurfaceUnlockNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueNousDiceSurfaceUnlockNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueNousDiceSurfaceUnlockNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DIAAMODKAMO != other.DIAAMODKAMO)
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
		if (DIAAMODKAMO != 0)
		{
			num ^= DIAAMODKAMO.GetHashCode();
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
		if (DIAAMODKAMO != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(DIAAMODKAMO);
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
		if (DIAAMODKAMO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DIAAMODKAMO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueNousDiceSurfaceUnlockNotify other)
	{
		if (other != null)
		{
			if (other.DIAAMODKAMO != 0)
			{
				DIAAMODKAMO = other.DIAAMODKAMO;
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
			if (num != 120)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				DIAAMODKAMO = input.ReadUInt32();
			}
		}
	}
}
