using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengePeakGroupDataUpdateScNotify : IMessage<ChallengePeakGroupDataUpdateScNotify>, IMessage, IEquatable<ChallengePeakGroupDataUpdateScNotify>, IDeepCloneable<ChallengePeakGroupDataUpdateScNotify>, IBufferMessage
{
	private static readonly MessageParser<ChallengePeakGroupDataUpdateScNotify> _parser = new MessageParser<ChallengePeakGroupDataUpdateScNotify>(() => new ChallengePeakGroupDataUpdateScNotify());

	private UnknownFieldSet _unknownFields;

	public const int ChallengePeakGroupFieldNumber = 2;

	private ChallengePeakGroup challengePeakGroup_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengePeakGroupDataUpdateScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengePeakGroupDataUpdateScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakGroup ChallengePeakGroup
	{
		get
		{
			return challengePeakGroup_;
		}
		set
		{
			challengePeakGroup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakGroupDataUpdateScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakGroupDataUpdateScNotify(ChallengePeakGroupDataUpdateScNotify other)
		: this()
	{
		challengePeakGroup_ = ((other.challengePeakGroup_ != null) ? other.challengePeakGroup_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengePeakGroupDataUpdateScNotify Clone()
	{
		return new ChallengePeakGroupDataUpdateScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengePeakGroupDataUpdateScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengePeakGroupDataUpdateScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ChallengePeakGroup, other.ChallengePeakGroup))
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
		if (challengePeakGroup_ != null)
		{
			num ^= ChallengePeakGroup.GetHashCode();
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
		if (challengePeakGroup_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(ChallengePeakGroup);
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
		if (challengePeakGroup_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ChallengePeakGroup);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengePeakGroupDataUpdateScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.challengePeakGroup_ != null)
		{
			if (challengePeakGroup_ == null)
			{
				ChallengePeakGroup = new ChallengePeakGroup();
			}
			ChallengePeakGroup.MergeFrom(other.ChallengePeakGroup);
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
			if (num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (challengePeakGroup_ == null)
			{
				ChallengePeakGroup = new ChallengePeakGroup();
			}
			input.ReadMessage(ChallengePeakGroup);
		}
	}
}
