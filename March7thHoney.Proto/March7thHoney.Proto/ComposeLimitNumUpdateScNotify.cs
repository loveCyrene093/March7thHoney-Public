using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ComposeLimitNumUpdateScNotify : IMessage<ComposeLimitNumUpdateScNotify>, IMessage, IEquatable<ComposeLimitNumUpdateScNotify>, IDeepCloneable<ComposeLimitNumUpdateScNotify>, IBufferMessage
{
	private static readonly MessageParser<ComposeLimitNumUpdateScNotify> _parser = new MessageParser<ComposeLimitNumUpdateScNotify>(() => new ComposeLimitNumUpdateScNotify());

	private UnknownFieldSet _unknownFields;

	public const int BDOJDMMEHEHFieldNumber = 6;

	private GHFBGBPMPFL bDOJDMMEHEH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ComposeLimitNumUpdateScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ComposeLimitNumUpdateScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GHFBGBPMPFL BDOJDMMEHEH
	{
		get
		{
			return bDOJDMMEHEH_;
		}
		set
		{
			bDOJDMMEHEH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComposeLimitNumUpdateScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComposeLimitNumUpdateScNotify(ComposeLimitNumUpdateScNotify other)
		: this()
	{
		bDOJDMMEHEH_ = ((other.bDOJDMMEHEH_ != null) ? other.bDOJDMMEHEH_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ComposeLimitNumUpdateScNotify Clone()
	{
		return new ComposeLimitNumUpdateScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ComposeLimitNumUpdateScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ComposeLimitNumUpdateScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BDOJDMMEHEH, other.BDOJDMMEHEH))
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
		if (bDOJDMMEHEH_ != null)
		{
			num ^= BDOJDMMEHEH.GetHashCode();
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
		if (bDOJDMMEHEH_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(BDOJDMMEHEH);
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
		if (bDOJDMMEHEH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BDOJDMMEHEH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ComposeLimitNumUpdateScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.bDOJDMMEHEH_ != null)
		{
			if (bDOJDMMEHEH_ == null)
			{
				BDOJDMMEHEH = new GHFBGBPMPFL();
			}
			BDOJDMMEHEH.MergeFrom(other.BDOJDMMEHEH);
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
			if (bDOJDMMEHEH_ == null)
			{
				BDOJDMMEHEH = new GHFBGBPMPFL();
			}
			input.ReadMessage(BDOJDMMEHEH);
		}
	}
}
