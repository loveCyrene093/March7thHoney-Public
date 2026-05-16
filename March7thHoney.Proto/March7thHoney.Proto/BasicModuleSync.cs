using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BasicModuleSync : IMessage<BasicModuleSync>, IMessage, IEquatable<BasicModuleSync>, IDeepCloneable<BasicModuleSync>, IBufferMessage
{
	private static readonly MessageParser<BasicModuleSync> _parser = new MessageParser<BasicModuleSync>(() => new BasicModuleSync());

	private UnknownFieldSet _unknownFields;

	public const int LPLEBJKDEICFieldNumber = 11;

	private uint lPLEBJKDEIC_;

	public const int StaminaFieldNumber = 13;

	private uint stamina_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BasicModuleSync> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BasicModuleSyncReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LPLEBJKDEIC
	{
		get
		{
			return lPLEBJKDEIC_;
		}
		set
		{
			lPLEBJKDEIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Stamina
	{
		get
		{
			return stamina_;
		}
		set
		{
			stamina_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BasicModuleSync()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BasicModuleSync(BasicModuleSync other)
		: this()
	{
		lPLEBJKDEIC_ = other.lPLEBJKDEIC_;
		stamina_ = other.stamina_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BasicModuleSync Clone()
	{
		return new BasicModuleSync(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BasicModuleSync);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BasicModuleSync other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LPLEBJKDEIC != other.LPLEBJKDEIC)
		{
			return false;
		}
		if (Stamina != other.Stamina)
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
		if (LPLEBJKDEIC != 0)
		{
			num ^= LPLEBJKDEIC.GetHashCode();
		}
		if (Stamina != 0)
		{
			num ^= Stamina.GetHashCode();
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
		if (LPLEBJKDEIC != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(LPLEBJKDEIC);
		}
		if (Stamina != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Stamina);
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
		if (LPLEBJKDEIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LPLEBJKDEIC);
		}
		if (Stamina != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Stamina);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BasicModuleSync other)
	{
		if (other != null)
		{
			if (other.LPLEBJKDEIC != 0)
			{
				LPLEBJKDEIC = other.LPLEBJKDEIC;
			}
			if (other.Stamina != 0)
			{
				Stamina = other.Stamina;
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 88u:
				LPLEBJKDEIC = input.ReadUInt32();
				break;
			case 104u:
				Stamina = input.ReadUInt32();
				break;
			}
		}
	}
}
