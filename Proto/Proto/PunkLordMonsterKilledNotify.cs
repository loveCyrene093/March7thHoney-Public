using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PunkLordMonsterKilledNotify : IMessage<PunkLordMonsterKilledNotify>, IMessage, IEquatable<PunkLordMonsterKilledNotify>, IDeepCloneable<PunkLordMonsterKilledNotify>, IBufferMessage
{
	private static readonly MessageParser<PunkLordMonsterKilledNotify> _parser = new MessageParser<PunkLordMonsterKilledNotify>(() => new PunkLordMonsterKilledNotify());

	private UnknownFieldSet _unknownFields;

	public const int PFOALOMJHDNFieldNumber = 5;

	private LMIINHHKLNL pFOALOMJHDN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PunkLordMonsterKilledNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PunkLordMonsterKilledNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMIINHHKLNL PFOALOMJHDN
	{
		get
		{
			return pFOALOMJHDN_;
		}
		set
		{
			pFOALOMJHDN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordMonsterKilledNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordMonsterKilledNotify(PunkLordMonsterKilledNotify other)
		: this()
	{
		pFOALOMJHDN_ = ((other.pFOALOMJHDN_ != null) ? other.pFOALOMJHDN_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordMonsterKilledNotify Clone()
	{
		return new PunkLordMonsterKilledNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PunkLordMonsterKilledNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PunkLordMonsterKilledNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PFOALOMJHDN, other.PFOALOMJHDN))
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
		if (pFOALOMJHDN_ != null)
		{
			num ^= PFOALOMJHDN.GetHashCode();
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
		if (pFOALOMJHDN_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(PFOALOMJHDN);
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
		if (pFOALOMJHDN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PFOALOMJHDN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PunkLordMonsterKilledNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pFOALOMJHDN_ != null)
		{
			if (pFOALOMJHDN_ == null)
			{
				PFOALOMJHDN = new LMIINHHKLNL();
			}
			PFOALOMJHDN.MergeFrom(other.PFOALOMJHDN);
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
			if (num != 42)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (pFOALOMJHDN_ == null)
			{
				PFOALOMJHDN = new LMIINHHKLNL();
			}
			input.ReadMessage(PFOALOMJHDN);
		}
	}
}
