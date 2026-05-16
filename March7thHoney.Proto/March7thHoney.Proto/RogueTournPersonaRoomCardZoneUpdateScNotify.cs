using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournPersonaRoomCardZoneUpdateScNotify : IMessage<RogueTournPersonaRoomCardZoneUpdateScNotify>, IMessage, IEquatable<RogueTournPersonaRoomCardZoneUpdateScNotify>, IDeepCloneable<RogueTournPersonaRoomCardZoneUpdateScNotify>, IBufferMessage
{
	private static readonly MessageParser<RogueTournPersonaRoomCardZoneUpdateScNotify> _parser = new MessageParser<RogueTournPersonaRoomCardZoneUpdateScNotify>(() => new RogueTournPersonaRoomCardZoneUpdateScNotify());

	private UnknownFieldSet _unknownFields;

	public const int EAHLEBKJIMLFieldNumber = 8;

	private GNLMENKBHLE eAHLEBKJIML_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournPersonaRoomCardZoneUpdateScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournPersonaRoomCardZoneUpdateScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GNLMENKBHLE EAHLEBKJIML
	{
		get
		{
			return eAHLEBKJIML_;
		}
		set
		{
			eAHLEBKJIML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournPersonaRoomCardZoneUpdateScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournPersonaRoomCardZoneUpdateScNotify(RogueTournPersonaRoomCardZoneUpdateScNotify other)
		: this()
	{
		eAHLEBKJIML_ = ((other.eAHLEBKJIML_ != null) ? other.eAHLEBKJIML_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournPersonaRoomCardZoneUpdateScNotify Clone()
	{
		return new RogueTournPersonaRoomCardZoneUpdateScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournPersonaRoomCardZoneUpdateScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournPersonaRoomCardZoneUpdateScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EAHLEBKJIML, other.EAHLEBKJIML))
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
		if (eAHLEBKJIML_ != null)
		{
			num ^= EAHLEBKJIML.GetHashCode();
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
		if (eAHLEBKJIML_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(EAHLEBKJIML);
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
		if (eAHLEBKJIML_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EAHLEBKJIML);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournPersonaRoomCardZoneUpdateScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eAHLEBKJIML_ != null)
		{
			if (eAHLEBKJIML_ == null)
			{
				EAHLEBKJIML = new GNLMENKBHLE();
			}
			EAHLEBKJIML.MergeFrom(other.EAHLEBKJIML);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			if (num != 66)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (eAHLEBKJIML_ == null)
			{
				EAHLEBKJIML = new GNLMENKBHLE();
			}
			input.ReadMessage(EAHLEBKJIML);
		}
	}
}
