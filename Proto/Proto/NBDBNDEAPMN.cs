using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NBDBNDEAPMN : IMessage<NBDBNDEAPMN>, IMessage, IEquatable<NBDBNDEAPMN>, IDeepCloneable<NBDBNDEAPMN>, IBufferMessage
{
	private static readonly MessageParser<NBDBNDEAPMN> _parser = new MessageParser<NBDBNDEAPMN>(() => new NBDBNDEAPMN());

	private UnknownFieldSet _unknownFields;

	public const int MMAOONPAPDPFieldNumber = 3;

	private CAEABHJNLMI mMAOONPAPDP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NBDBNDEAPMN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NBDBNDEAPMNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CAEABHJNLMI MMAOONPAPDP
	{
		get
		{
			return mMAOONPAPDP_;
		}
		set
		{
			mMAOONPAPDP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBDBNDEAPMN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBDBNDEAPMN(NBDBNDEAPMN other)
		: this()
	{
		mMAOONPAPDP_ = ((other.mMAOONPAPDP_ != null) ? other.mMAOONPAPDP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBDBNDEAPMN Clone()
	{
		return new NBDBNDEAPMN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NBDBNDEAPMN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NBDBNDEAPMN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MMAOONPAPDP, other.MMAOONPAPDP))
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
		if (mMAOONPAPDP_ != null)
		{
			num ^= MMAOONPAPDP.GetHashCode();
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
		if (mMAOONPAPDP_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(MMAOONPAPDP);
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
		if (mMAOONPAPDP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MMAOONPAPDP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NBDBNDEAPMN other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mMAOONPAPDP_ != null)
		{
			if (mMAOONPAPDP_ == null)
			{
				MMAOONPAPDP = new CAEABHJNLMI();
			}
			MMAOONPAPDP.MergeFrom(other.MMAOONPAPDP);
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
			if (num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (mMAOONPAPDP_ == null)
			{
				MMAOONPAPDP = new CAEABHJNLMI();
			}
			input.ReadMessage(MMAOONPAPDP);
		}
	}
}
