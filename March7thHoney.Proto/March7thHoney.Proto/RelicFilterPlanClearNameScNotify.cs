using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RelicFilterPlanClearNameScNotify : IMessage<RelicFilterPlanClearNameScNotify>, IMessage, IEquatable<RelicFilterPlanClearNameScNotify>, IDeepCloneable<RelicFilterPlanClearNameScNotify>, IBufferMessage
{
	private static readonly MessageParser<RelicFilterPlanClearNameScNotify> _parser = new MessageParser<RelicFilterPlanClearNameScNotify>(() => new RelicFilterPlanClearNameScNotify());

	private UnknownFieldSet _unknownFields;

	public const int KKGIEENCOICFieldNumber = 14;

	private uint kKGIEENCOIC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RelicFilterPlanClearNameScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RelicFilterPlanClearNameScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KKGIEENCOIC
	{
		get
		{
			return kKGIEENCOIC_;
		}
		set
		{
			kKGIEENCOIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicFilterPlanClearNameScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicFilterPlanClearNameScNotify(RelicFilterPlanClearNameScNotify other)
		: this()
	{
		kKGIEENCOIC_ = other.kKGIEENCOIC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicFilterPlanClearNameScNotify Clone()
	{
		return new RelicFilterPlanClearNameScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RelicFilterPlanClearNameScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RelicFilterPlanClearNameScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KKGIEENCOIC != other.KKGIEENCOIC)
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
		if (KKGIEENCOIC != 0)
		{
			num ^= KKGIEENCOIC.GetHashCode();
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
		if (KKGIEENCOIC != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(KKGIEENCOIC);
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
		if (KKGIEENCOIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KKGIEENCOIC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RelicFilterPlanClearNameScNotify other)
	{
		if (other != null)
		{
			if (other.KKGIEENCOIC != 0)
			{
				KKGIEENCOIC = other.KKGIEENCOIC;
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
			if (num != 112)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				KKGIEENCOIC = input.ReadUInt32();
			}
		}
	}
}
