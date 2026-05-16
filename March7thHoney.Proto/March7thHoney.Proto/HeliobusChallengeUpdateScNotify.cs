using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HeliobusChallengeUpdateScNotify : IMessage<HeliobusChallengeUpdateScNotify>, IMessage, IEquatable<HeliobusChallengeUpdateScNotify>, IDeepCloneable<HeliobusChallengeUpdateScNotify>, IBufferMessage
{
	private static readonly MessageParser<HeliobusChallengeUpdateScNotify> _parser = new MessageParser<HeliobusChallengeUpdateScNotify>(() => new HeliobusChallengeUpdateScNotify());

	private UnknownFieldSet _unknownFields;

	public const int OPCGNJMGJDEFieldNumber = 6;

	private HeliobusChallengeData oPCGNJMGJDE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HeliobusChallengeUpdateScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HeliobusChallengeUpdateScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusChallengeData OPCGNJMGJDE
	{
		get
		{
			return oPCGNJMGJDE_;
		}
		set
		{
			oPCGNJMGJDE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusChallengeUpdateScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusChallengeUpdateScNotify(HeliobusChallengeUpdateScNotify other)
		: this()
	{
		oPCGNJMGJDE_ = ((other.oPCGNJMGJDE_ != null) ? other.oPCGNJMGJDE_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusChallengeUpdateScNotify Clone()
	{
		return new HeliobusChallengeUpdateScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HeliobusChallengeUpdateScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HeliobusChallengeUpdateScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(OPCGNJMGJDE, other.OPCGNJMGJDE))
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
		if (oPCGNJMGJDE_ != null)
		{
			num ^= OPCGNJMGJDE.GetHashCode();
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
		if (oPCGNJMGJDE_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(OPCGNJMGJDE);
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
		if (oPCGNJMGJDE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OPCGNJMGJDE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HeliobusChallengeUpdateScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oPCGNJMGJDE_ != null)
		{
			if (oPCGNJMGJDE_ == null)
			{
				OPCGNJMGJDE = new HeliobusChallengeData();
			}
			OPCGNJMGJDE.MergeFrom(other.OPCGNJMGJDE);
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
			if (num != 50)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (oPCGNJMGJDE_ == null)
			{
				OPCGNJMGJDE = new HeliobusChallengeData();
			}
			input.ReadMessage(OPCGNJMGJDE);
		}
	}
}
