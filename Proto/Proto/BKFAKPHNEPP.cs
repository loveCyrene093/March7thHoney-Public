using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BKFAKPHNEPP : IMessage<BKFAKPHNEPP>, IMessage, IEquatable<BKFAKPHNEPP>, IDeepCloneable<BKFAKPHNEPP>, IBufferMessage
{
	private static readonly MessageParser<BKFAKPHNEPP> _parser = new MessageParser<BKFAKPHNEPP>(() => new BKFAKPHNEPP());

	private UnknownFieldSet _unknownFields;

	public const int MONILNMIBLGFieldNumber = 15;

	private LFDHOPEMOPL mONILNMIBLG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BKFAKPHNEPP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BKFAKPHNEPPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LFDHOPEMOPL MONILNMIBLG
	{
		get
		{
			return mONILNMIBLG_;
		}
		set
		{
			mONILNMIBLG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BKFAKPHNEPP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BKFAKPHNEPP(BKFAKPHNEPP other)
		: this()
	{
		mONILNMIBLG_ = ((other.mONILNMIBLG_ != null) ? other.mONILNMIBLG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BKFAKPHNEPP Clone()
	{
		return new BKFAKPHNEPP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BKFAKPHNEPP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BKFAKPHNEPP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MONILNMIBLG, other.MONILNMIBLG))
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
		if (mONILNMIBLG_ != null)
		{
			num ^= MONILNMIBLG.GetHashCode();
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
		if (mONILNMIBLG_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(MONILNMIBLG);
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
		if (mONILNMIBLG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MONILNMIBLG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BKFAKPHNEPP other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mONILNMIBLG_ != null)
		{
			if (mONILNMIBLG_ == null)
			{
				MONILNMIBLG = new LFDHOPEMOPL();
			}
			MONILNMIBLG.MergeFrom(other.MONILNMIBLG);
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
			if (num != 122)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (mONILNMIBLG_ == null)
			{
				MONILNMIBLG = new LFDHOPEMOPL();
			}
			input.ReadMessage(MONILNMIBLG);
		}
	}
}
