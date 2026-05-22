using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightSummonProjectionCsReq : IMessage<GridFightSummonProjectionCsReq>, IMessage, IEquatable<GridFightSummonProjectionCsReq>, IDeepCloneable<GridFightSummonProjectionCsReq>, IBufferMessage
{
	private static readonly MessageParser<GridFightSummonProjectionCsReq> _parser = new MessageParser<GridFightSummonProjectionCsReq>(() => new GridFightSummonProjectionCsReq());

	private UnknownFieldSet _unknownFields;

	public const int JCMFPHMFAONFieldNumber = 5;

	private uint jCMFPHMFAON_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightSummonProjectionCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightSummonProjectionCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JCMFPHMFAON
	{
		get
		{
			return jCMFPHMFAON_;
		}
		set
		{
			jCMFPHMFAON_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSummonProjectionCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSummonProjectionCsReq(GridFightSummonProjectionCsReq other)
		: this()
	{
		jCMFPHMFAON_ = other.jCMFPHMFAON_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSummonProjectionCsReq Clone()
	{
		return new GridFightSummonProjectionCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightSummonProjectionCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightSummonProjectionCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JCMFPHMFAON != other.JCMFPHMFAON)
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
		if (JCMFPHMFAON != 0)
		{
			num ^= JCMFPHMFAON.GetHashCode();
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
		if (JCMFPHMFAON != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(JCMFPHMFAON);
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
		if (JCMFPHMFAON != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JCMFPHMFAON);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightSummonProjectionCsReq other)
	{
		if (other != null)
		{
			if (other.JCMFPHMFAON != 0)
			{
				JCMFPHMFAON = other.JCMFPHMFAON;
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
			if (num != 40)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				JCMFPHMFAON = input.ReadUInt32();
			}
		}
	}
}
