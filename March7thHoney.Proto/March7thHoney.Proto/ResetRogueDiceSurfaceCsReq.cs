using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ResetRogueDiceSurfaceCsReq : IMessage<ResetRogueDiceSurfaceCsReq>, IMessage, IEquatable<ResetRogueDiceSurfaceCsReq>, IDeepCloneable<ResetRogueDiceSurfaceCsReq>, IBufferMessage
{
	private static readonly MessageParser<ResetRogueDiceSurfaceCsReq> _parser = new MessageParser<ResetRogueDiceSurfaceCsReq>(() => new ResetRogueDiceSurfaceCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BDJDBMICKKPFieldNumber = 6;

	private GLENEKHDKLJ bDJDBMICKKP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ResetRogueDiceSurfaceCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ResetRogueDiceSurfaceCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLENEKHDKLJ BDJDBMICKKP
	{
		get
		{
			return bDJDBMICKKP_;
		}
		set
		{
			bDJDBMICKKP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ResetRogueDiceSurfaceCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ResetRogueDiceSurfaceCsReq(ResetRogueDiceSurfaceCsReq other)
		: this()
	{
		bDJDBMICKKP_ = ((other.bDJDBMICKKP_ != null) ? other.bDJDBMICKKP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ResetRogueDiceSurfaceCsReq Clone()
	{
		return new ResetRogueDiceSurfaceCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ResetRogueDiceSurfaceCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ResetRogueDiceSurfaceCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BDJDBMICKKP, other.BDJDBMICKKP))
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
		if (bDJDBMICKKP_ != null)
		{
			num ^= BDJDBMICKKP.GetHashCode();
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
		if (bDJDBMICKKP_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(BDJDBMICKKP);
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
		if (bDJDBMICKKP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BDJDBMICKKP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ResetRogueDiceSurfaceCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.bDJDBMICKKP_ != null)
		{
			if (bDJDBMICKKP_ == null)
			{
				BDJDBMICKKP = new GLENEKHDKLJ();
			}
			BDJDBMICKKP.MergeFrom(other.BDJDBMICKKP);
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
			if (bDJDBMICKKP_ == null)
			{
				BDJDBMICKKP = new GLENEKHDKLJ();
			}
			input.ReadMessage(BDJDBMICKKP);
		}
	}
}
